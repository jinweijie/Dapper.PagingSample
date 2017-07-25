using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper.PagingSample.Common;
using Dapper.PagingSample.Entity;
using Dapper.PagingSample.Logging;
using Dapper.PagingSample.Repository;

namespace Dapper.PagingSample
{
    public partial class Main : Form
    {
        private static readonly ILog Logger = LogProvider.GetCurrentClassLogger();

        public Main()
        {
            Logger.InfoFormat("Starting InitializeComponent...");

            InitializeComponent();

            this.txtConnectionString.Text = ConfigurationManager.ConnectionStrings["DapperPagingSample"]
                .ConnectionString;

            Logger.InfoFormat("InitializeComponent complete.");

        }

        private LogRepository GetRepository()
        {
            return new LogRepository(this.txtConnectionString.Text);
        }

        private LogSearchCriteria GetCritera()
        {
            return new LogSearchCriteria
            {
                Level = this.txtLevel.Text,
                Message = this.txtMessage.Text
            };
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var repo = GetRepository();
            Tuple<IEnumerable<Log>, int> result;

            var sortings = new List<SortDescriptor>();
            if (!string.IsNullOrWhiteSpace(this.txtSortAsc.Text))
                sortings.Add(new SortDescriptor { Direction = SortDescriptor.SortingDirection.Ascending, Field = this.txtSortAsc.Text.Trim() });

            if (!string.IsNullOrWhiteSpace(this.txtSortDesc.Text))
                sortings.Add(new SortDescriptor { Direction = SortDescriptor.SortingDirection.Descending, Field = this.txtSortDesc.Text.Trim() });


            if (this.rbNormal.Checked)
            {

                result = repo.Find(GetCritera(),
                    int.Parse(this.txtPageIndex.Text),
                    int.Parse(this.txtPageSize.Text),
                    sortings);
            }
            else if(rbOffsetFetch.Checked)
            {
                result = repo.FindWithOffsetFetch(GetCritera(),
                    int.Parse(this.txtPageIndex.Text),
                    int.Parse(this.txtPageSize.Text),
                    sortings);
            }
            else
            {
                return;
            }

            this.dgvData.DataSource = result.Item1;
            this.lTotalCountValue.Text = result.Item2.ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            int current = int.Parse(this.txtPageIndex.Text);
            var pre = current-1;
            if (pre < 0)
                pre = 0;

            this.txtPageIndex.Text = pre.ToString();

            btnSearch.PerformClick();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int current = int.Parse(this.txtPageIndex.Text);
            var next = current + 1;
            if (next < 0)
                next = 0;

            this.txtPageIndex.Text = next.ToString();

            btnSearch.PerformClick();
        }
        
        private void btnGenerateInfoLog_Click(object sender, EventArgs e)
        {

            var r = new Random();
            for (int i = 0; i < 100; i++)
            {
                Logger.InfoFormat("Randomly generated Info log:{0}", r.Next(1000, 1000000));
            }

            MessageBox.Show("100 info log entries has been generated.");
        }
    }
}
