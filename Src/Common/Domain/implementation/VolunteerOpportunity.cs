﻿using System;
using System.Collections.Generic;

namespace Ttu.Domain
{
    public class VolunteerOpportunity : IVolunteerOpportunity
    {

        #region Constructors

        public VolunteerOpportunity()
            : this(null, null)
        {
        }

        public VolunteerOpportunity(IUser createdBy, IOrganization organization)
        {
            CreatedBy = createdBy;
            Organization = organization;

            RecordId = 0;

            ProjectName = string.Empty;
            ProjectDescription = string.Empty;

            StartTime = DateTime.Today;
            StopTime = DateTime.Today;

            MinimumVolunteers = 0;
            MaximumVolunteers = 0;
        }

        #endregion

        #region Properties

        public virtual IUser CreatedBy { get; set; }
        public virtual IOrganization Organization { get; set; }

        public virtual int RecordId { get; set; }

        public virtual string ProjectName { get; set; }
        public virtual string ProjectDescription { get; set; }

        public virtual DateTime StartTime { get; set; }
        public virtual DateTime StopTime { get; set; }

        public virtual int MinimumVolunteers { get; set; }
        public virtual int MaximumVolunteers { get; set; }

        #endregion

        #region Public Methods

        public virtual bool IsCurrent()
        {
            return StartTime >= DateTime.Today;
        }

        public virtual bool IsPrevious()
        {
            return StartTime < DateTime.Today;
        }

        #endregion

    }
}
