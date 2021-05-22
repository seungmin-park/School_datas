using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    /// <summary>
    /// 극단적인 추상 클래스
    /// abstract class -> 변수, 메소드, (추상메소드) -> 타입, 값으로 존재할 수 없음
    /// interface -> 변수x, 메소드x, (추상 메소드),etc -> 타입, 값으로 x
    /// </summary>
    interface IAnalyzable
    {
        bool MinMaxAvg(ref Subject min, ref Subject max, out double avg);
    }
}
