using GuitarApp.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GuitarApp.Models
{
    internal class GuitarFeatures
    {
        private Builder _builder;
        private string _model;
        private Types _type;
        private Wood _backwood;
        private Wood _topwood;
        private int _numStrings;


        public GuitarFeatures(Builder builder, string model, Types type, Wood backwood, Wood topwood,int numString)
        {
            _builder = builder;
            _model = model;
            _type = type;
            _backwood = backwood;
            _topwood = topwood;
            _numStrings = numString;
        }

        public Builder GetBuilder()
        {
            return _builder;
        }
        public string GetModel()
        {
            return _model;
        }
        public int GetNumString()
        {
            return _numStrings;
        }
        public Types GetType()
        {
            return _type;
        }
        public Wood GetBackWood()
        {
            return _backwood;
        }
        public Wood GetTopWood()
        {
            return _topwood;
        }

        public bool Matches(GuitarFeatures otherGuitar)
        {
            string model = otherGuitar.GetModel().ToLower();
            if (otherGuitar.GetBuilder() != _builder)
                return false;
            else if (model != null && model != "" && !model.Equals(GetModel().ToLower()))
                return false;
            else if (otherGuitar.GetType() != _type)
                return false;
            else if (otherGuitar.GetBackWood() != _backwood)
                return false;
            else if(otherGuitar.GetNumString() != _numStrings)
                return false;
            else if (otherGuitar.GetTopWood() != _topwood)
                return false;
            return true;
        }
    }
}
