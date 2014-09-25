using System.Collections.Generic;
using System.Linq;

namespace Peons.Qualities
{
    public class Qualifier<T> : IQualifier<T>
    {
        private readonly IEnumerable<IQuality<T>> qualities;

        public Qualifier(IEnumerable<IQuality<T>> qualities)
        {
            if (qualities == null)
                throw new ArgNullException(() => qualities);

            this.qualities = qualities;
        }

        public IEnumerable<IQuality<T>> Qualities
        {
            get { return this.qualities; }
        }

        public IEnumerable<IQuality<T>> Qualify(T target)
        {
            var applicableQualities =
                from quality in this.Qualities
                where quality.AppliesTo(target)
                select quality;
            return applicableQualities;
        }
    }
}
