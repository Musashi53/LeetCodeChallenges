namespace LeetCodeChallenges.Challenges
{
    public static class TwoSumChallenge
    {
        public static int[] Solution(int[] nums, int target)
        {
            /*
                1 - Damos a entrada dos números dentro de um Array e o target.

                2 - Enquanto o res não for igual ao target, somaremos os valores dos índices repetidamente.

                3 - A soma deve ser:
                    somar o valor do índice 0 e o índice 1, 
                    soma índice 1 e índice 2
                    e assim repetidamente até chegar no último índice

                4 - Se o resultado da soma for igual ao target:
                    criamos um novo Array com o valor dos índices

                5 - Retornamos os índices do Array que cuja soma dos mesmos é igual ao target


                soma o primeiro e o segundo índice, se o resultado for igual ao target, retorna os índices dos números cujo resultado dão o mesmo valor do target. Se não, avança mais uma casa do índice para soma.


            */
            var sum = 0;
            while(sum != target)
            {
                sum = nums[0] + nums[1];
            }
            return nums;
        }
    }
}