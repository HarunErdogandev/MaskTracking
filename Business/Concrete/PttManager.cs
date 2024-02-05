
using Business.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete;

public class PttManager:ISupplierManager
{
    private IApplicantService _applicantService;

    public PttManager(IApplicantService applicantService)
    {
         _applicantService = applicantService;
    }
    public void GiveMask(Person person)
    {
        if (_applicantService.CheckPerson(person))
        {
            Console.WriteLine("Maske verildi"+person.FirstName);
        }
        else
        {
            Console.WriteLine("Maske verilemedi "+person.FirstName);
        }
    }
}
