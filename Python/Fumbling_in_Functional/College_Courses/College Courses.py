def collegeCourses(x, courses):
    def shouldConsider(course):
        return len(course) != x

    return filter(shouldConsider, courses)
