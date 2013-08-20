﻿using Glimpse.Core.Extensibility;

using Xunit;

namespace Sitecore.Glimpse.Test
{
    public class SitecoreGlimpseShould
    {
        private readonly SitecoreTab _sut;

        public SitecoreGlimpseShould()
        {
            _sut = new SitecoreTab();
        }

        [Fact]
        public void Provide_a_sitecore_tab()
        {
            Assert.IsAssignableFrom<ITab>(_sut);
        }
    
        [Fact]
        public void Name_tab_Sitecore()
        {
            Assert.Equal("Sitecore", _sut.Name);
        }
    }
}