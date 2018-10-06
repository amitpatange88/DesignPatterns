using BuilderPattern.Builder.ConcreteBuilder;
using BuilderPattern.Builder.Director;
using BuilderPattern.Builder.IBuilder;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //without using builder design pattern call.
            //here we have one problem if in future requirement is changed to add
            //one more ComputerSystem configuration type like Mouse/touch pad and keyboard then 
            //we then need to update construtor param which is bad for changes. So we use builder pattern.
            ComputerSystem cs = new ComputerSystem("8GB", "1TB");
            string systemConfig = cs.GetSystem();

            //So we implement builder pattern here. Start Builer design pattern implementation.
            Dictionary<string, string> collection = new Dictionary<string, string>();
            collection["Drive"] = "8GB";
            collection["Memory"] = "1TB";
            collection["Mouse"] = "NA";
            collection["KeyBoard"] = "MS";
            collection["TouchScreen"] = "Enabled";

            //Step:1 Concrete Builder
            ISystemBuilder systemBuilder = new LaptopBuilder();
            
            //step:2 Director
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.BuildSystem(systemBuilder, collection);

            //Step:3 Return the system
            ComputerSystemProduct product = systemBuilder.GetSystem();

            //Step:4 Get Final Product info.
            string SystemConfigDetails = product.GetFinalProduct(product);
        }
    }
}
