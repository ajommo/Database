using System.ComponentModel.DataAnnotations.Schema;

namespace Game.Database.Models
{
    [Table("Bundle")]
    public class BundleEntity
    {
        private string id;
        private string name;
        private string version;

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Version
        {
            get => version;
            set => version = value;
        }
    }
}
