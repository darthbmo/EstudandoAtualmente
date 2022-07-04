using Throw;

namespace EstudosGerais.Throw
{
    public static class ThrowExceptions
    {
        public static bool IfNullOrEmptyWhiteSpace(string val)
        {   
            if (string.IsNullOrWhiteSpace(val))
            {
                return false;
            }

            return true;
        }

        public static void ThrowWhiteSpaceOrEmptyAndLength(string val)
        {
            //val.Throw().IfEmpty().IfWhiteSpace();
            val.Throw("String should not be empty or white space only.")
                    .IfEmpty()
                    .IfWhiteSpace()
                .Throw()
                    .IfLongerThan(10)
                    .IfShorterThan(3);
        }

    }
}
