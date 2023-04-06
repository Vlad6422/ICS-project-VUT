﻿using Time2Plan.BL.Models;
using Time2Plan.DAL.Interfaces;

namespace Time2Plan.BL.Mappers.Interfaces;

public interface IUserModelMapper : IModelMapper<UserEntity, UserListModel, UserDetailModel>
{
}