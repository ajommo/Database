using System.ComponentModel.DataAnnotations.Schema;

namespace Game.Database.Models
{
    [Table("Asset")]
    public class AssetEntity
    {
        private string id;
        private string bundle;
        private string name;
        private string prefab;
        private int version;

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Bundle
        {
            get => bundle;
            set => bundle = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Prefab
        {
            get => prefab;
            set => prefab = value;
        }

        public int Version
        {
            get => version;
            set => version = value;
        }
    }
}
