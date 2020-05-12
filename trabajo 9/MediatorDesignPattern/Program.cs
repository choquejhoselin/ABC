using System;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Mediator mediador = new Mediator();

            IColleague oPepe = new User(mediador);
            IColleague oAdmin = new UserAdmin(mediador);
            IColleague oAdmin2 = new UserAdmin(mediador);

            mediador.Add(oPepe);
            mediador.Add(oAdmin);
            mediador.Add(oAdmin2);

            oPepe.Communicate("Administrador tengo un problema");
            Console.WriteLine("modificado por : Victor Morales");
            Console.ReadKey();
        }
        
    }
   
   
}
