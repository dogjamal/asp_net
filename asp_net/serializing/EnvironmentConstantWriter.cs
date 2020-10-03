using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace asp_net.serializing
{
    public class EnvironmentConstantWriter
    {
        public void Write_down()
        {
            var environment_constant = new EnvironmentConstant();

            string object_serialized  =  JsonSerializer.Serialize(environment_constant);
            File.WriteAllText("EnvironmentConstant.json", object_serialized);
        }
    }
}
