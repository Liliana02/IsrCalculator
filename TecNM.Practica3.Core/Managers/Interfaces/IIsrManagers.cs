using TecNM.Practica3.Core.Entities;

namespace TecNM.Practica3.Core.Managers.Interfaces;

public interface IIsrManager{
    Isr GetIsr(Person person);
}