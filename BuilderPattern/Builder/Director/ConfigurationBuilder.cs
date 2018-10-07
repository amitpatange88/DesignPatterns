using BuilderPattern.Builder.IBuilder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Builder.Director
{
    public class ConfigurationBuilder
    {
        public void BuildSystem(ISystemBuilder systemBuilder, IDictionary collection)
        {
            systemBuilder.AddDrive(collection["Drive"].ToString());
            systemBuilder.AddMemory(collection["Memory"].ToString());
            systemBuilder.AddMouse(collection["Mouse"].ToString());
            systemBuilder.AddKeyBoard(collection["KeyBoard"].ToString());
            systemBuilder.AddTouchScreen(collection["TouchScreen"].ToString());
            systemBuilder.AddTouchScreen(collection["Processor"].ToString());
        }
    }
}
