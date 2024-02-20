using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Managers.Interfaces;
using TecNM.Practica3.Core.Services.Interfaces;

namespace TecNM.Practica3.Core.Managers;

public class IsrManager : IIsrManager{
    private readonly IIsrService _service;
    public IsrManager(IIsrService service){
        _service = service;
    }
    public Isr GetIsr(Person person){
            return _service.ProcessIsr(person);
        }
}