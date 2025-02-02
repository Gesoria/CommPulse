﻿namespace CommPulse.DAL.Entities
{
    public class Channel
    {
        /// <summary>
        /// ID канала
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Создатель канала
        /// </summary>
        public ApplicationUser Creator { get; set; }

        /// <summary>
        /// Название канала
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Описание канала
        /// </summary>
        public string? Description { get; set; } 
        
        /// <summary>
        /// Участники канала
        /// </summary>
        public List<ApplicationUser>? Members { get; set; }
    }
}
