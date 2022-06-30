
int[] nums = { -1,1,0,-3,3 };

(int preProduct, int postProduct)[] ProductArray = new (int, int)[nums.Length];
ProductArray[0].preProduct = nums[0];
ProductArray[^1].postProduct = nums[^1];
for(int i = 1; i < nums.Length; i++)
{
    ProductArray[i].preProduct = ProductArray[i-1].preProduct * nums[i];
    ProductArray[^(i + 1)].postProduct = ProductArray[^i].postProduct * nums[^(i + 1)];
}
int[] answers = new int[ProductArray.Length];
answers[0] = ProductArray[1].postProduct;
answers[^1] = ProductArray[^2].preProduct;
for(int i = 1; i < answers.Length-1; i++)
{
    answers[i] = ProductArray[i-1].preProduct * ProductArray[i+1].postProduct;
}


//int[] postProduct = new int[nums.Length];
//int[] preProduct = new int[nums.Length];
//preProduct[0] = nums[0];
//postProduct[^1] = nums[^1];
//for(int i = 1; i < nums.Length; i++)
//{
//    preProduct[i] = preProduct[i-1] * nums[i];
//    postProduct[^(i+1)] = postProduct[^(i)] * nums[^(i+1)];
//}
//int[] answers = new int[nums.Length];
//answers[0] = postProduct[1];
//answers[^1] = preProduct[^2];
//for(int i = 1; i < answers.Length - 1; i++)
//{
//    answers[i] = preProduct[i-1] * postProduct[i+1];
//}
foreach (int i in answers)
{
    Console.WriteLine(i);
}