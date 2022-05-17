using KetCRM.Application.Models;
using KetCRM.Application.Models.Groups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KetCRM.Application.Common.Interfaces.Groups
{
    public interface IGroupService
    {
        Task<Result<Guid>> CreateGroup(CreateGroupDto GroupDto);
        Task<Result<Guid>> UpdateGroup(UpdateGroupDto GroupDto, Guid GroupId);
        Task<Result<Guid>> DeleteGroup(Guid GroupId);
        Task<Result<GroupDto>> GetGroupById(Guid GroupId);
        Task<Result<GroupListDto>> GetAllGroup();
    }
}
