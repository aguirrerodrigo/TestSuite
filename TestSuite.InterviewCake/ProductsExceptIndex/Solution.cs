namespace TestSuite.InterviewCake.ProductExceptIndex
{
    public static class Solution
    {
        public static int[] GetProductsExceptIndex(params int[] input)
        {
            var products = new int[input.Length];

            var product = 1;
            for (var i = 0; i < input.Length; i++)
            {
                products[i] = product;
                product *= input[i];
            }

            product = 1;
            for(var i = input.Length - 1; i >= 0; i--)
            {
                products[i] *= product;
                product *= input[i];
            }

            return products;
        }
    }
}
