using TecNM.Practica3.Core.Entities;
using TecNM.Practica3.Core.Services;

namespace TecNM.Practica3.Tests
{
    public class IsrServiceTests
    {
        [Fact]
        public void CalculateIsrForRangeOne()
        {
            var person = new Person { Salario = 0.01f };
            var isrService = new IsrService();
            
            var isr = isrService.ProcessIsr(person);
            
            Assert.Equal((person.Salario - 0.01f) * (0.192f / 100f), isr.IsrT);
        }

        [Fact]
        public void CalculateIsrForRangeTwo()
        {
            var person = new Person { Salario = 7735.01f };
            var isrService = new IsrService();
            
            var isr = isrService.ProcessIsr(person);
            
            Assert.Equal(((person.Salario - 7735.01f) * (6.40f / 100f)) + 148.51f, isr.IsrT);
        }
        [Fact]
        public void CalculateIsrForRangeThree()
        {
            var person = new Person { Salario = 65651.08f };
            var isrService = new IsrService();
            
            var isr = isrService.ProcessIsr(person);
            
            Assert.Equal(((person.Salario - 65651.08f) * (10.88f / 100f)) + 3855.14f, isr.IsrT);
        }
        [Fact]
        public void CalculateIsrForRangeFour()
        {
            var person = new Person { Salario = 115375.91f };
            var isrService = new IsrService();
            
            var isr = isrService.ProcessIsr(person);
            
            Assert.Equal(((person.Salario - 115375.91f) * (16f / 100f)) + 9265.20f, isr.IsrT);
        }
        [Fact]
        public void CalculateIsrForRangeFive()
        {
            var person = new Person { Salario = 134119.42f };
            var isrService = new IsrService();
            
            var isr = isrService.ProcessIsr(person);
            
            Assert.Equal(((person.Salario - 134119.42f) * (17.92f / 100f)) + 12264.16f, isr.IsrT);
        }
        [Fact]
        public void CalculateIsrForRangeSix()
        {
            var person = new Person { Salario = 160577.66f };
            var isrService = new IsrService();
            
            var isr = isrService.ProcessIsr(person);
            
            Assert.Equal(((person.Salario - 160577.66f) * (21.36f / 100f)) + 17005.47f, isr.IsrT);
        }
        [Fact]
        public void CalculateIsrForRangeSeven()
        {
            var person = new Person { Salario = 323862.01f };
            var isrService = new IsrService();
            
            var isr = isrService.ProcessIsr(person);
            
            Assert.Equal(((person.Salario - 323862.01f) * (23.52f / 100f)) + 51883.01f, isr.IsrT);
        }
        [Fact]
        public void CalculateIsrForRangeEight()
        {
            var person = new Person { Salario = 510451.01f };
            var isrService = new IsrService();
            
            var isr = isrService.ProcessIsr(person);
            
            Assert.Equal(((person.Salario - 510451.01f) * (30f / 100f)) + 95768.74f, isr.IsrT);
        }
        [Fact]
        public void CalculateIsrForRangeNine()
        {
            var person = new Person { Salario = 974535.04f };
            var isrService = new IsrService();
            
            var isr = isrService.ProcessIsr(person);
            
            Assert.Equal(((person.Salario - 974535.04f) * (32f / 100f)) + 234993.95f, isr.IsrT);
        }
        [Fact]
        public void CalculateIsrForRangeTen()
        {
            var person = new Person { Salario = 1299380.05f };
            var isrService = new IsrService();
            
            var isr = isrService.ProcessIsr(person);
            
            Assert.Equal(((person.Salario - 1299380.05f) * (34f / 100f)) + 338944.34f, isr.IsrT);
        }
        [Fact]
        public void CalculateIsrForRangeEleven()
        {
            var person = new Person { Salario = 3898140.13f };
            var isrService = new IsrService();
            
            var isr = isrService.ProcessIsr(person);
            
            Assert.Equal(((person.Salario - 3898140.13f) * (35f / 100f)) + 1222522.76f, isr.IsrT);
        }
    }
}