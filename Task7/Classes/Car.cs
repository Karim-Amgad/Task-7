using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Car
    {
        #region Attributes
        private int id;
        private string model;
        private decimal price;
        #endregion

        #region Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string MODEL
        {
            get { return model; }
            set { model = value; }
        }
        public decimal PRICE
        {
            get { return price; }
            set { price = value; }
        }
        #endregion

        #region Constructors
        public Car()
        {

        }

        public Car(int _id)
        {
            id = _id;
        }
        public Car(int _id, string _model)
        {
            id = _id;
            model = _model;
        }
        public Car(int _id, string _model, decimal _price)
        {
            id = _id;
            model = _model;
            price = _price;
        }
        #endregion

        #region Override
        public override string ToString()
        {
            return $"The id is {id}, the model is {model}, the price is {price}";
        }
        #endregion
    }
}
