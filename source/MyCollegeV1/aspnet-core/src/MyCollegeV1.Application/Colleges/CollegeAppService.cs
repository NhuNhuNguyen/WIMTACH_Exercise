using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using MyCollegeV1.Authorization;
using MyCollegeV1.Colleges.Dto;
using MyCollegeV1.Models;

namespace MyCollegeV1.Colleges
{

    [AbpAuthorize(PermissionNames.Pages_Colleges)]
    public class CollegeAppService : AsyncCrudAppService<College, CollegeDto, int, PagedCollegeResultRequestDto, CreateCollegeDto, UpdateCollegeDto>, ICollegeAppService
    {
        public CollegeAppService
        (
            IRepository<College, int> repository
        )
        : base(repository)
        {

        }

    }
}
