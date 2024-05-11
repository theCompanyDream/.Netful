using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _Net.Test.Utils {
    public Mock<DbSet<T>> CreateMockSet<T>(IQueryable<T> data) where T : class
    {
        var mockSet = new Mock<DbSet<T>>();
        mockSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(data.Provider);
        mockSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(data.Expression);
        mockSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(data.ElementType);
        mockSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());
        return mockSet;
    }

    public Mock<MyDbContext> CreateMockContext<T>(Mock<DbSet<T>> mockSet, Func<MyDbContext, DbSet<T>> func) where T : class
    {
        var mockContext = new Mock<MyDbContext>();
        mockContext.Setup(c => func(c)).Returns(mockSet.Object);
        return mockContext;
    }
}

