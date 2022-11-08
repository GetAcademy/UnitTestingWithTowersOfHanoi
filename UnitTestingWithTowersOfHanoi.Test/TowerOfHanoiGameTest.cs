namespace UnitTestingWithTowersOfHanoi.Test
{
    public class TowerOfHanoiGameTest
    {
        [Test]
        public void TestStartState()
        {
            // arrange - set opp alt som trengs
            var game = new TowerOfHanoiGame();

            // act - gjør det som du skal sjekke om virker
            var text = game.GetText();

            // assert - sjekk om det virket
            Assert.AreEqual("1,2,3,4,5--", text);
        }

        [Test]
        public void TestLegalMove()
        {
            // arrange - set opp alt som trengs
            var game = new TowerOfHanoiGame();

            // act - gjør det som du skal sjekke om virker
            game.Move(0, 1);
            var text = game.GetText();

            // assert - sjekk om det virket
            Assert.AreEqual("2,3,4,5-1-", text);
        }

        [Test]
        public void TestIllegalMove()
        {
            // arrange - set opp alt som trengs
            var game = new TowerOfHanoiGame();

            // act - gjør det som du skal sjekke om virker
            game.Move(0, 1);
            var isSuccess  = game.Move(0, 1);
            var text = game.GetText();

            // assert - sjekk om det virket
            Assert.AreEqual("2,3,4,5-1-", text);
            Assert.IsFalse(isSuccess);
        }
    }
}