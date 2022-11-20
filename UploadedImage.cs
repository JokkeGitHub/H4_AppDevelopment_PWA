using Microsoft.AspNetCore.Components.Forms;

namespace H4_AppDevelopment_PWA
{
    public class UploadedImage
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Base64Data { get; set; }
        public long Size { get; set; }
        public IBrowserFile File { get; set; }
    }
}
