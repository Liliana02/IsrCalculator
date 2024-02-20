using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Services.Interfaces;

namespace TecNM.Practica3.Core.Services;

public class IsrService : IIsrService{
    public Isr ProcessIsr(Person person){
        var isr = new Isr();
        if (person.Salario >= 0.01f && person.Salario <= 7735.00f)
        {
            isr.IsrT = (person.Salario - 0.01f)*(0.192f/100f);
        }
        if (person.Salario >= 7735.01f && person.Salario <= 65651.07f)
        {
            isr.IsrT = ((person.Salario - 7735.01f)*(06.40f/100f))+148.51f;
        }
        if (person.Salario >= 65651.08f && person.Salario <= 115375.90f)
        {
            isr.IsrT = ((person.Salario - 65651.08f)*(10.88f/100f))+3855.14f;
        }
        if (person.Salario >= 115375.91f && person.Salario <= 134119.41f)
        {
            isr.IsrT = ((person.Salario - 115375.91f)*(16f/100f))+9265.20f;
        }
        if (person.Salario >= 134119.42f && person.Salario <= 160577.65f)
        {
            isr.IsrT = ((person.Salario - 134119.42f)*(17.92f/100f))+12264.16f;
        }
        if (person.Salario >= 160577.66f && person.Salario <= 323862.00f)
        {
            isr.IsrT = ((person.Salario - 160577.66f)*(21.36f/100f))+17005.47f;
        }
        if (person.Salario >= 323862.01f && person.Salario <= 510451.00f)
        {
            isr.IsrT = ((person.Salario - 323862.01f)*(23.52f/100f))+51883.01f;
        }
        if (person.Salario >= 510451.01f && person.Salario <= 974535.03f)
        {
            isr.IsrT = ((person.Salario - 510451.01f)*(30f/100f))+95768.74f;
        }
        if (person.Salario >= 974535.04f && person.Salario <= 1299380.04f)
        {
            isr.IsrT = ((person.Salario - 974535.04f)*(32f/100f))+234993.95f;
        }
        if (person.Salario >= 1299380.05f && person.Salario <= 3898140.12f)
        {
            isr.IsrT = ((person.Salario - 1299380.05f)*(34f/100f))+338944.34f;
        }
        if (person.Salario >= 3898140.13f )
        {
            isr.IsrT = ((person.Salario - 3898140.13f)*(35f/100f))+1222522.76f;
        }
        return isr;
    }
}