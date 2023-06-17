#  Петя, Катя и Сережа делают из бумаги журавликов.
#  Вместе они сделали S журавликов. Сколько журавликов сделал каждый ребенок, если известно,
# что Петя и Сережа сделали одинаковое количество журавликов,
# а Катя сделала в два раза больше журавликов, чем Петя и Сережа вместе?

# *Пример:*

# 6 -> 1  4  1
# 24 -> 4  16  4
#     60 -> 10  40  10

x = 0
while True:
    if x + x + 3*x == 24:
        print("Петя и Сережа сделали по ", x, "журавлику, а Катя сделала", 3*x, "журавлика.")
        break
    else:
        x += 1