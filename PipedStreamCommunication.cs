using System;
using System.IO.Pipes;
using System.IO;
using System.Threading;
namespace Assignment_21_Streams
{
    class PipedStreamCommunication
    {
        static void Main()
        {
            using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
            using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.GetClientHandleAsString()))
            {
                Thread writerThread = new Thread(() => WriteToPipe(pipeServer));
                Thread readerThread = new Thread(() => ReadFromPipe(pipeClient));

                writerThread.Start();
                readerThread.Start();

                writerThread.Join();
                readerThread.Join();
            }
        }
        static void WriteToPipe(AnonymousPipeServerStream pipeServer)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(pipeServer))
                {
                    writer.AutoFlush = true;  // Ensure data is immediately sent
                    for (int i = 1; i <= 5; i++)
                    {
                        string message = $"Message {i} from Writer";
                        Console.WriteLine($"[Writer] Sending: {message}");
                        writer.WriteLine(message);
                        Thread.Sleep(1000); // Simulate processing delay
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"[Writer] Error: {ex.Message}");
            }
        }
        static void ReadFromPipe(AnonymousPipeClientStream pipeClient)
        {
            try
            {
                using (StreamReader reader = new StreamReader(pipeClient))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine($"[Reader] Received: {line}");
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine($"[Reader] Error: {ex.Message}");
            }
        }
    }
}
