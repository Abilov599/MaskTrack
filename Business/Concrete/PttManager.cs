using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class PttManager(IApplicantService applicantService) : ISupplierService
{
    public void GiveMask(Person person)
    {
        if (applicantService.CheckPerson(person))
        {
            Console.WriteLine($"Mask given to {person.FirstName}");
        }
        else
        {
            Console.WriteLine($"Mask not given to {person.FirstName}");
        }
    }
}