using System;
using System.Globalization;
using System.Resources;

namespace YourNamespace.Resources  // 替換為實際的命名空間
{
    /// <summary>
    ///   這個類別是用於查找在 Labels.resx 中的字串。
    /// </summary>
    public class Labels
    {
        private static ResourceManager resourceMan;

        private static CultureInfo resourceCulture;

        /// <summary>
        ///   返回此類的資源管理器實例。
        /// </summary>
        public static ResourceManager ResourceManager
        {
            get
            {
                if (resourceMan == null)
                {
                    resourceMan = new ResourceManager("YourNamespace.Resources.Labels", typeof(Labels).Assembly);
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   使用當前文化的字串。
        /// </summary>
        public static CultureInfo Culture
        {
            get => resourceCulture;
            set => resourceCulture = value;
        }

        /// <summary>
        ///   返回 Labels.resx 中的字串。
        /// </summary>
        public static string Welcome => ResourceManager.GetString("Welcome", resourceCulture);
        // 添加更多屬性來訪問其他資源字串
    }
}