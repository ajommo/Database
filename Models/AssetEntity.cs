using System.ComponentModel.DataAnnotations.Schema;

namespace Game.Database.Models
{
    [Table("Asset")]
    public class AssetEntity
    {
        private string id;
        private string name;
        private int version;
        private bool active;
        private string prefab;
        private string bundle;

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

        public string Prefab
        {
            get => prefab;
            set => prefab = value;
        }

        public string Bundle
        {
            get => bundle;
            set => bundle = value;
        }
    }
}
