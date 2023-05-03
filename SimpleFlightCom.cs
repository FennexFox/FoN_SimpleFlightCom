namespace simpleCalc_Data
{
    using System;
    using System.Numerics;

    public class basicParams{ // needless to say, all the data below shall be in SI units.
        public const double G = 6.6720e-11; // Units newtons*m^2/kg^2
        public static readonly Vector3 referenceDirection = new Vector3(0f, 0f, 1f); // This shall be re-defined using Unity Vector3 before implemented as a mod.

        // public double SGP ()

        public interface IBodyParams{ // Parameters for objects with its own gravity well
            string name{get; private set;}

            float mass{get; private set;}
            float diameter{get; private set;}
            float axialTilt{get; private set;}
            float siderealRotationPeriod{get; private set;}
        }

        public interface IOrbitalParams{
            float inclination{get; private set;}
            float eccentricity{get; private set;}
            float apoapsis{get; private set;}
            float periapsis{get; private set;}

            float trueAnomaly{get; private set;}
            float argumentOfPeriapsis{get; private set;}
            float longitudeOfAN{get; private set;} // 3 floats above could be defined as vector3, but let me see.
        }

        public interface IFixedFascilityParams{
            string originBodyName{get; private set;}

            float latitude{get; private set;}
            float longitude{get; private set;}
            float altitude{get; private set;}

            Vector3 initialVelocity{get; private set;} // This shall be re-defined using Unity Vector3 before implemented as a mod.
        }

/*
      public class CelestialBody : IBodyParams, IOrbitalParams{
            public CelestialBody( ... ){
                name = ;
                mass = ; diameter = ; axialTilt = ; siderealRotationPeriod = ;
                inclination = ; eccentricity = ; Apoapsis = ; Periapsis = ;
                trueAnomaly = ; argumentOfPeriapsis = ; longitudeOfAN = ;
            }
        }
*/
    }

}