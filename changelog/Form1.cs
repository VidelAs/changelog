using LibGit2Sharp;
using System.Text;

namespace changelog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string GenerateChangelog()
        {
            var result = new StringBuilder();

            using (var repo = new Repository("C:\\Users\\videl.araya\\Documents\\code\\bas\\changelog"))
            {
                var commits = repo.Commits.QueryBy(new CommitFilter { SortBy = CommitSortStrategies.Time });

                foreach (var commit in commits)
                {
                    result.AppendLine($"### {commit.MessageShort}");
                    result.AppendLine();
                    result.AppendLine(commit.Message);
                    result.AppendLine();
                }
                Console.WriteLine(commits.Count());
            }

            return result.ToString();
        }

        private void btnMostrarCommits_Click(object sender, EventArgs e)
        {
            txtCommits.Text = GenerateChangelog();
        }
    }
}