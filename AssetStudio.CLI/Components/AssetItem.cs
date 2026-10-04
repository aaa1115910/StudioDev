namespace AssetStudio.CLI
{
    public class AssetItem
    {
        public string Text;
        public Object Asset;
        public SerializedFile SourceFile;
        public string Container = string.Empty;
        public string TypeString;
        public long m_PathID;
        public long FullSize;
        public ClassIDType Type;
        public string InfoText;
        public string UniqueID;

        /// <summary>
        /// True when <see cref="Container"/> came from a container that declares this
        /// asset as its primary asset, rather than from one that merely references it.
        /// A primary assignment must not be overwritten by a referencing container.
        /// </summary>
        public bool IsContainerFromPrimary;

        public AssetItem(Object asset)
        {
            Asset = asset;
            Text = asset.Name;
            SourceFile = asset.assetsFile;
            Type = asset.type;
            TypeString = Type.ToString();
            m_PathID = asset.m_PathID;
            FullSize = asset.byteSize;
        }
    }
}
