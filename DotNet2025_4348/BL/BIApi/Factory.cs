namespace BIApi
{
    public static class Factory
    {
        private static IBI bi = new BIImplementation.BI();
        public static IBI Get()
        {
            return bi;
        }
    }
}
