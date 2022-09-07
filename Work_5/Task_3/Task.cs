namespace Work_5.Task_3
{
    public static class Task
    {
        private static string _fileName = "bytes.bin";

        public static void Run()
        {
            InputData input = new InputData();
            input.Input(_fileName);
            OutputData output = new OutputData();
            output.Output(_fileName);
        }
    }
}
