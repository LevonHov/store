namespace Store.Test
{
    public class BookTests
    {
        [Fact]
        public void IsIsbn_WithNull_ReturnFalse()
        {
            bool actual = Book.IsIsbm(null);
            Assert.False(actual);
        }
        [Fact]
        public void IsIsbn_WithBlankString_ReturnFalse()
        {
            bool actual = Book.IsIsbm("   ");
            Assert.False(actual);
        }
        [Fact]
        public void IsIsbn_WithINvalidIsbn_ReturnFalse()
        {
            bool actual = Book.IsIsbm("ISBN 123");
            Assert.False(actual);
        }
        [Fact]
        public void IsIsbn_WithIsbn10_ReturnTrue()
        {
            bool actual = Book.IsIsbm("IsBn 123-123-546 0");
            Assert.True(actual);
        }
        [Fact]
        public void IsIsbn_WithTrashStart_ReturnTrue()
        {
            bool actual = Book.IsIsbm("xxx IsBn 123-123-546 0 xxx");
            Assert.False(actual);
        }
    }
}