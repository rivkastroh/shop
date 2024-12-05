
namespace DO;

public class DalIDNumberDoesnotExistException : Exception
{
    public DalIDNumberDoesnotExistException(String message="") :base(message)
    {
        
    }
}
public class DalIDNumberAlreadyExistsException : Exception
{
    public DalIDNumberAlreadyExistsException(String message="") : base(message)
    {
        
    }
}
public class DalEntityAlreadyExistedException : Exception
{
    public DalEntityAlreadyExistedException(String message = "") : base(message)
    {
        
    }
}
