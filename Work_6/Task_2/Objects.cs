namespace Work_6.Task_2
{
    public class Objects
    {
        protected InputData _inputData;
        protected Serializer _serilizer;
        protected Deserializer _deserilizer;
        protected OutputData _outputData;

        public Objects()
        {
            _inputData = new InputData();
            _serilizer = new Serializer();
            _deserilizer = new Deserializer();
            _outputData = new OutputData();
        }
    }
}
