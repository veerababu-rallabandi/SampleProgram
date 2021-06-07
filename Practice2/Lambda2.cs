using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;//import namespace first

namespace Practice1
{
    class Lambda2
    {
        static void Main(string[] args)
        {
            //Expression tree
            //(15+15)-(3-2)

            //(15+15)
            BinaryExpression bE1 = Expression.MakeBinary(ExpressionType.Add, Expression.Constant(15), Expression.Constant(15));

            //(3-2)
            BinaryExpression bE2 = Expression.MakeBinary(ExpressionType.Add, Expression.Constant(3), Expression.Constant(2));

            //(15+15)-(3-2)
            BinaryExpression bE3 = Expression.MakeBinary(ExpressionType.Subtract, bE1, bE2);

            Console.WriteLine(bE3);
            Console.WriteLine(bE3.ToString());

            //This statement will create a delegate by parsing the expression tree.
            int result = Expression.Lambda<Func<int>>(bE3).Compile()();

            Console.WriteLine(result);
        }

    }
}
