﻿using System.Threading.Tasks;
using Volo.CmsKit.Pages;

namespace Volo.CmsKit.Public.Pages
{
    public class PagePublicAppService : CmsKitPublicAppServiceBase, IPagePublicAppService
    {
        protected IPageRepository PageRepository { get; }

        public PagePublicAppService(IPageRepository pageRepository)
        {
            PageRepository = pageRepository;
        }

        public virtual async Task<PageDto> FindBySlugAsync(string slug)
        {
            PageDto pageDto = null;
            var page = await PageRepository.FindBySlugAsync(slug);

            if (page !=null)
            {
                pageDto = ObjectMapper.Map<Page, PageDto>(page);
            }
            
            return pageDto;
        }
    }
}