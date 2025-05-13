﻿namespace BabyCareProject.DataAccess.Settings
{
    public interface IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string InstructorCollectionName { get; set; }
        public string ProductCollectionName { get; set; }
        public string AboutCollectionName { get; set; }
        public string BannerCollectionName { get; set; }
        public string EventCollectionName { get; set; }
        public string GalleryCollectionName { get; set; }
        public string InformationCollectionName { get; set; }
        public string ServiceCollectionName { get; set; }
        public string SubscribeCollectionName { get; set; }
        public string TestimonialCollectionName { get; set; }
    }
}
