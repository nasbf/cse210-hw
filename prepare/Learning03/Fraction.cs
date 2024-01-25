using System.ComponentModel.DataAnnotations;
using System.Xml.XPath;

public class Fraction
    {
        private int _numerador;
        private int _denominador;

        public Fraction ()
        {
            _numerador = 1;
            _denominador = 1;

        }
        public Fraction (int first)
        {
            _numerador = first;
            _denominador = 1;

        }
        public Fraction (int first, int last)
        {
            _numerador = first;
            _denominador = last;

        }
        public string GetFraction()
        {
            string newFraction = $"{_numerador}/{_denominador}";
            return newFraction ;
        }

        public double GetDecimal()
        {
            return (double)_numerador / (double) _denominador;
        } 
        
    }


    
    
    
