using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WeBcalculadora
{
    // Interfaz para todas las operaciones
    public interface IOperacion
    {
        string Nombre { get; }
        float Calcular(float valor1, float valor2 = 0);
        bool EsOperacionUnaria { get; }
    }

    // Clase base abstracta
    public abstract class OperacionBase : IOperacion
    {
        public abstract string Nombre { get; }
        public abstract float Calcular(float valor1, float valor2 = 0);
        public virtual bool EsOperacionUnaria => false;
    }

    // Operaciones binarias
    public class Suma : OperacionBase
    {
        public override string Nombre => "Suma";
        public override float Calcular(float valor1, float valor2 = 0) => valor1 + valor2;
    }

    public class Resta : OperacionBase
    {
        public override string Nombre => "Resta";
        public override float Calcular(float valor1, float valor2 = 0) => valor1 - valor2;
    }

    public class Multiplicacion : OperacionBase
    {
        public override string Nombre => "Multiplicación";
        public override float Calcular(float valor1, float valor2 = 0) => valor1 * valor2;
    }

    public class Division : OperacionBase
    {
        public override string Nombre => "División";
        public override float Calcular(float valor1, float valor2 = 0)
        {
        
            return valor1 / valor2;
        }
    }

    // Operaciones unarias
    public class Exponente2 : OperacionBase
    {
        public override string Nombre => "Cuadrado";
        public override float Calcular(float valor1, float valor2 = 0) => valor1 * valor1;
        public override bool EsOperacionUnaria => true;
    }

    public class Exponente3 : OperacionBase
    {
        public override string Nombre => "Cubo";
        public override float Calcular(float valor1, float valor2 = 0) => valor1 * valor1 * valor1;
        public override bool EsOperacionUnaria => true;
    }

    public class RaizCuadrada : OperacionBase
    {
        public override string Nombre => "Raíz Cuadrada";
        public override float Calcular(float valor1, float valor2 = 0)
        {
            if (valor1 == 0 || valor1 == 1)
                return valor1;

            double bajo = 0;
            double alto = valor1;
            double medio = 0;
            double precision = 0.00001;

            if (valor1 < 1)
                alto = 1;

            while (alto - bajo > precision)
            {
                medio = (bajo + alto) / 2;
                double cuadrado = medio * medio;

                if (cuadrado > valor1)
                    alto = medio;
                else
                    bajo = medio;
            }

            return (float)((bajo + alto) / 2);
        }
        public override bool EsOperacionUnaria => true;
    }

    public class Fibonacci : OperacionBase
    {
        public override string Nombre => "Fibonacci";
        public override float Calcular(float valor1, float valor2 = 0)
        {
            int num1 = 0;
            int num2 = 1;
            long limit = 0;
            num1 = 0;
            num2 = 1;
            limit = 1;
            while (limit != valor1)
            {
                num2 = num1 + num2;
                num1 = num2 - num1;
                limit = limit + 1;
            }
            return num2;
        }
        public override bool EsOperacionUnaria => true;
    }

    public class Factorial : OperacionBase
    {
        public override string Nombre => "Factorial";
        public override float Calcular(float valor1, float valor2 = 0)
        {
            if (valor1 == 0 || valor1 == 1)
                return 1;

            ulong num1 = 1;
            ulong num2 = 1;
            long limit = 0;
            while (limit != valor1)
            {
                num2 = num1 * num2;
                num1 = num1 + 1;
                limit = limit + 1;
            }
            return num2;
        }
        public override bool EsOperacionUnaria => true;
    }

    // Gestor de operaciones simplificado
    public class GestorOperaciones
    {
        private IOperacion _operacionActual;
        private float _valor1;
        private float _valor2;

        public void EstablecerOperacion(IOperacion operacion)
        {
            _operacionActual = operacion;
        }

        public void EstablecerValor1(float valor)
        {
            _valor1 = valor;
        }

        public void EstablecerValor2(float valor)
        {
            _valor2 = valor;
        }

        public float EjecutarOperacion()
        {
            return _operacionActual.Calcular(_valor1, _valor2);
        }

        public float EjecutarOperacionUnaria(float valor)
        {
            return _operacionActual.Calcular(valor);
        }

        public bool EsOperacionUnaria()
        {
            return _operacionActual?.EsOperacionUnaria ?? false;
        }

        public void Limpiar()
        {
            _operacionActual = null;
            _valor1 = 0;
            _valor2 = 0;
        }
    }
}

