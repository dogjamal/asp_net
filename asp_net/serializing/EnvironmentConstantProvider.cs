using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace asp_net.serializing
{
    public class EnvironmentConstantProvider
    {
        private const string nameJson = "EnvironmentConstan.json";

        public void Provide(out EnvironmentConstant environmentConstantObject)
        {
            string objectJsonFile = File.ReadAllText(nameJson);
            environmentConstantObject = JsonSerializer.Deserialize<EnvironmentConstant>(objectJsonFile);
        }
    }
}
