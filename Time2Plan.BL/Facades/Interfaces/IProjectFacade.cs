﻿using Time2Plan.BL.Models;
using Time2Plan.DAL.Interfaces;

namespace Time2Plan.BL.Facades.Interfaces
{
    internal interface IProjectFacade : IFacade<ProjectEntity, ProjectListModel, ProjectDetailModel>
    {
    }
}