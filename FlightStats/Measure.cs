using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightStats
{
    public class Measure
    {
        #region private attributes
        #endregion private attributes

        #region constructors
        public Measure(string dataFromLog)
        {
            //extraire chaque valeur dans un tableau
            //parcourir le tableau
            //si on détecte un élément "vide" puis un élément renseigné -> throw
            throw In
        }

        public Measure(double temperatureInFahrenheit)
        {
            throw new NotImplementedException();
        }

        public Measure(double  temperatureInFahrenheit, double temperatureInCelsius)
        {
            throw new NotImplementedException();
        }

        public Measure(double temperatureInFahrenheit, double temperatureInCelsius, double temperatureInKelvin)
        {
            throw new NotImplementedException();
        }

        public Measure(double temperatureInFahrenheit, double temperatureInCelsius, double temperatureInKelvin, double localSpeedOfSound)
        {
            throw new NotImplementedException();
        }
        #endregion constructors

        #region public accessors and mutators methods
        public override string ToString()
        {
            throw new NotImplementedException();
        }
        #endregion public accessors and mutators methods

        #region private methods
        public bool CheckLogFormat()
        {
            throw new NotImplementedException();
        }
        #endregion private methods
    }

    public class MeasureException : Exception { }
    public class WrongFormatMeasureException : Exception { }
}
