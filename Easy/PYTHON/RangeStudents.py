def range_students(redShirtStudents, blueShirtStudents):
    redShirtStudents.sort(reverse=True)
    blueShirtStudents.sort(reverse=True)

    for i in range(0, len(redShirtStudents)):
        if redShirtStudents[0] > blueShirtStudents[0]:
            if redShirtStudents[i] <= blueShirtStudents[i]:
                return False
        else:
            if redShirtStudents[i] >= blueShirtStudents[i]:
                return False

    return True


redRow = [19, 19, 21, 1, 1, 1, 1, 1]
blueRow = [20, 5, 4, 4, 4, 4, 4, 4]
result = range_students(redRow, blueRow)
print(result)
