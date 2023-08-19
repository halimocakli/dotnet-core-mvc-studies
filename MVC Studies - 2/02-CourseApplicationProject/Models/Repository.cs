namespace _02_CourseApplicationProject.Models
{
    // Uygulama çalışır halde iken Candidate modeli ile gelen veriyi tutacağız, In memory.
    public static class Repository
    {
        private static List<Candidate> applications = new();

        // IEnumerable tipindevbir yapı oluşturarak Candidate sınıfının itere edilebilir formatta olmasını sağlarız.
        public static IEnumerable<Candidate> Applications => applications;

        public static void Add(Candidate candidate)
        {
            applications.Add(candidate);
        }
    }
}