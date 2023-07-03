using LibGit2Sharp;
using System;
using System.Text;

namespace changelog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string GetCommitChanges(Commit commit, Repository repo)
        {
            var result = new StringBuilder();

            if (commit.Parents.Any())
            {
                var parentCommit = commit.Parents.First().Tree;
                var currentCommit = commit.Tree;

                var changes = repo.Diff.Compare<Patch>(parentCommit, currentCommit);

                foreach (var change in changes)
                {
                    result.AppendLine($"Change Type: {change.Status}");
                    result.AppendLine($"Path: {change.Path}");
                    result.AppendLine($"\n{change.Patch}");
                    result.AppendLine();
                }
            }

            return result.ToString();
        }

        public static string GenerateChangelog()
        {
            var result = new StringBuilder();

            using (var repo = new Repository("C:\\Users\\videl.araya\\Documents\\code\\bas\\BAS-Reporter"))
            {
                var commits = repo.Commits.QueryBy(new CommitFilter { SortBy = CommitSortStrategies.Time });

                foreach (var commit in commits)
                {
                    result.AppendLine($"{commit.Author.Name}");
                    result.AppendLine($"{commit.Author.When}");
                    result.AppendLine(commit.Message);

                    var commitChanges = GetCommitChanges(commit, repo);
                    result.AppendLine(commitChanges);
                    result.AppendLine("------------------------------------------------------------------");
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
