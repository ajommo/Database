using System.ComponentModel.DataAnnotations.Schema;

namespace Game.Database.Models
{
    [Table("Bundle")]
    public class BundleEntity
    {
        private string id;
        private string name;
        private int version;
        private bool active;

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

        public int Version
        {
            get => version;
            set => version = value;
        }

        public bool Active
        {
            get => active;
            set => active = value;
        }
    }
}
