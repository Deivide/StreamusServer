﻿using FluentNHibernate.Mapping;
using Streamus.Domain;

namespace Streamus.Dao.Mappings
{
    public class VideoMapping : ClassMap<Video>
    {
        public VideoMapping()
        {
            Table("[Videos]");
            Not.LazyLoad(); 
            ReadOnly(); 
            
            Id(e => e.Id).GeneratedBy.Assigned().Length(11);

            Map(e => e.Title).Not.Nullable();
            Map(e => e.Duration).Not.Nullable();
            Map(e => e.Author).Not.Nullable();
            Map(e => e.HighDefinition).Not.Nullable();
        }
    }
}