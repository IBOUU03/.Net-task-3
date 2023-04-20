using System.Collections.Generic;
using Task3.Models;

namespace Task3.ViewModels
{
    public class ServiceViewModel
    {
        public List<SerFeature> Features { get; set; }
        public List<SerFeature> SerFeatures { get; internal set; }
    }
}
