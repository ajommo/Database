using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Game.Database.Models
{
    [Table("Instance")]
    public class InstanceEntity
    {
        private Guid id;
        private string description;
        private string asset;
        private byte[] scale;
        private byte[] rotation;
        private byte[] translation;

        public Guid Id
        {
            get => id;
            set => id = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public string Asset
        {
            get => asset;
            set => asset = value;
        }

        public byte[] Scale
        {
            get => scale;
            set => scale = value;
        }

        public byte[] Rotation
        {
            get => rotation;
            set => rotation = value;
        }

        public byte[] Translation
        {
            get => translation;
            set => translation = value;
        }
    }
}
