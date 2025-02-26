using Newtonsoft.Json;
using System.Net.Http.Headers;
using DataProductCrawlTool.Model;
using System.Windows.Forms;

namespace DataProductCrawlTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void buttonGoiAPI_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;

            HttpClient client = new HttpClient();

            string apiKey = "f-dd47c47ddf1807db6637ac431d5de3f7";

            //Add key
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(apiKey);

            List<Product> allProducts = new List<Product>();

            string category = "sneakers";
            //Số trang lấy data
            int totalPages = 1;
            //Số sp mỗi trang
            int limit = 100;   //Max là 100

            try
            {
                //Lấy data ở 40 trang đầu, mỗi trang 100 sản phẩm = 4000 sản phẩm
                for (int i = 0; i < totalPages; i++)
                {
                    //URL API
                    string url = $"https://api.sneakersapi.dev/api/v3/stockx/products?category={category}&limit={limit}&page={i}";

                    //Gửi yêu cầu
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    //Đọc phản hồi
                    string responseBody = await response.Content.ReadAsStringAsync();

                    //In ra RichTextBox
                    richTextBoxDataTraVe.Text += responseBody;

                    // Chuyển đổi JSON thành obj để lấy ds sản phẩm trong data
                    ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseBody);

                    // Lấy danh sách sản phẩm trong data
                    foreach (var product in apiResponse.Data)
                    {
                        string code = CreateProductCode(allProducts);
                        Product product1 = new Product
                        {
                            Id = product.Id,
                            Code = code,
                            Name = product.Title,
                            Status = "Active",
                            ImageUrl = product.Image,
                            SortOrder = null,
                            Description = product.Description,
                            MainCategoryId = null,
                            RelatedIds = null,
                            WorkFlowStates = null,
                            PublicOnDate = null,
                            MetadataJson = $"[{{\"Id\":\"{Guid.NewGuid().ToString()}\",\"ParentId\":null,\"RelatedFieldNames\":null,\"FieldName\":\"Brand\",\"DisplayName\":null,\"Placeholder\":null,\"FieldType\":18,\"DefaultValue\":null,\"FieldValues\":\"{product.Brand}\",\"FieldValueTexts\":null,\"FieldSelectionValues\":null,\"AllowNulls\":false,\"SortOrder\":0,\"AllowSearch\":true,\"AllowToView\":true,\"AllowToModify\":true,\"IsMultipleLanguage\":false,\"FieldDisplayName\":null,\"FieldValueType\":null,\"PrefixValue\":null,\"SuffixValue\":null}},{{\"Id\":\"{Guid.NewGuid().ToString()}\",\"ParentId\":null,\"RelatedFieldNames\":null,\"FieldName\":\"Model\",\"DisplayName\":null,\"Placeholder\":null,\"FieldType\":18,\"DefaultValue\":null,\"FieldValues\":\"{product.Model}\",\"FieldValueTexts\":null,\"FieldSelectionValues\":null,\"AllowNulls\":false,\"SortOrder\":0,\"AllowSearch\":true,\"AllowToView\":true,\"AllowToModify\":true,\"IsMultipleLanguage\":false,\"FieldDisplayName\":null,\"FieldValueType\":null,\"PrefixValue\":null,\"SuffixValue\":null}},{{\"Id\":\"{Guid.NewGuid().ToString()}\",\"ParentId\":null,\"RelatedFieldNames\":null,\"FieldName\":\"SKU\",\"DisplayName\":null,\"Placeholder\":null,\"FieldType\":18,\"DefaultValue\":null,\"FieldValues\":\"{product.SKU}\",\"FieldValueTexts\":null,\"FieldSelectionValues\":null,\"AllowNulls\":false,\"SortOrder\":0,\"AllowSearch\":true,\"AllowToView\":true,\"AllowToModify\":true,\"IsMultipleLanguage\":false,\"FieldDisplayName\":null,\"FieldValueType\":null,\"PrefixValue\":null,\"SuffixValue\":null}},{{\"Id\":\"{Guid.NewGuid().ToString()}\",\"ParentId\":null,\"RelatedFieldNames\":null,\"FieldName\":\"PriceMin\",\"DisplayName\":null,\"Placeholder\":null,\"FieldType\":0,\"DefaultValue\":null,\"FieldValues\":\"{product.Min_Price}\",\"FieldValueTexts\":null,\"FieldSelectionValues\":null,\"AllowNulls\":false,\"SortOrder\":0,\"AllowSearch\":true,\"AllowToView\":true,\"AllowToModify\":true,\"IsMultipleLanguage\":false,\"FieldDisplayName\":null,\"FieldValueType\":null,\"PrefixValue\":\"$\",\"SuffixValue\":\"USD\"}},{{\"Id\":\"{Guid.NewGuid().ToString()}\",\"ParentId\":null,\"RelatedFieldNames\":null,\"FieldName\":\"PriceMax\",\"DisplayName\":null,\"Placeholder\":null,\"FieldType\":0,\"DefaultValue\":null,\"FieldValues\":\"{product.Max_Price}\",\"FieldValueTexts\":null,\"FieldSelectionValues\":null,\"AllowNulls\":false,\"SortOrder\":0,\"AllowSearch\":true,\"AllowToView\":true,\"AllowToModify\":true,\"IsMultipleLanguage\":false,\"FieldDisplayName\":null,\"FieldValueType\":null,\"PrefixValue\":\"$\",\"SuffixValue\":\"USD\"}},{{\"Id\":\"{Guid.NewGuid().ToString()}\",\"ParentId\":null,\"RelatedFieldNames\":null,\"FieldName\":\"PriceAvg\",\"DisplayName\":null,\"Placeholder\":null,\"FieldType\":0,\"DefaultValue\":null,\"FieldValues\":\"{product.Avg_Price}\",\"FieldValueTexts\":null,\"FieldSelectionValues\":null,\"AllowNulls\":false,\"SortOrder\":0,\"AllowSearch\":true,\"AllowToView\":true,\"AllowToModify\":true,\"IsMultipleLanguage\":false,\"FieldDisplayName\":null,\"FieldValueType\":null,\"PrefixValue\":\"$\",\"SuffixValue\":\"USD\"}},{{\"Id\":\"{Guid.NewGuid().ToString()}\",\"ParentId\":null,\"RelatedFieldNames\":null,\"FieldName\":\"Link\",\"DisplayName\":null,\"Placeholder\":null,\"FieldType\":30,\"DefaultValue\":null,\"FieldValues\":\"{product.Link}\",\"FieldValueTexts\":null,\"FieldSelectionValues\":null,\"AllowNulls\":false,\"SortOrder\":0,\"AllowSearch\":true,\"AllowToView\":true,\"AllowToModify\":true,\"IsMultipleLanguage\":false,\"FieldDisplayName\":null,\"FieldValueType\":null,\"PrefixValue\":null,\"SuffixValue\":null}}]",
                            CompleteName = product.Title,
                            CompletePath = product.Link,
                            CompleteCode = code,
                            LabelsJson = "[]",
                            CreatedByUserId = null,
                            LastModifiedByUserId = null,
                            LastModifiedOnDate = product.Updated_At,
                            CreatedOnDate = product.Created_At,
                            Isdeleted = false
                        };

                        allProducts.Add(product1);
                    }
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Lỗi API: {ex.Message}");

                panel1.Visible = false;
                return;
            }

            productBindingSource.DataSource = allProducts;

            foreach (DataGridViewRow row in dataGridViewDataLuuVaoDb.Rows)
            {
                row.Cells["STT"].Value = row.Index + 1;
            }

            panel1.Visible = false;
        }

        //Hàm tạo mã Code mới cho sản phẩm
        public static string CreateProductCode(List<Product> allListProduct)
        {
            if (allListProduct == null || allListProduct.Count == 0)
            {
                return "P1";
            }

            //Lấy ra danh sách Product Code
            var existingCodes = allListProduct
                .Where(p => !string.IsNullOrEmpty(p.Code) && p.Code.StartsWith("P") && int.TryParse(p.Code.Substring(1), out _))
                .Select(p => int.Parse(p.Code.Substring(1)))
                .ToList();

            int newNumber = existingCodes.Count > 0 ? existingCodes.Max() + 1 : 1; //Lấy số lớn nhất + 1
            return $"P{newNumber}";
        }

        private async void buttonLuuVaoDb_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Dock = DockStyle.Fill;

            try
            {
                using (var db = new DatnShoemasterContext())
                {
                    await db.Products.AddRangeAsync(productBindingSource.DataSource as List<Product>);
                    await db.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi lưu data vào DB: {ex.Message}");

                panel1.Visible = false;
                return;
            }

            MessageBox.Show("Lưu data vào DB thành công!");

            panel1.Visible = false;
        }
    }
}
