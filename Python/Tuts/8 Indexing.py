#Indexing allows us to grab one or multiple values inside a list using the [] (indexing operators)
#       [start:end:step(bond)]

credit_number = "1234-5678-9012-3456"

index_num = credit_number[0]

index_num = credit_number[5:18]
index_num = credit_number[:19]

index_num = credit_number[-1]

index_num = credit_number[0:19:2]
index_num = credit_number[::2] #same as line 11

index_num = credit_number[-4:]

index_num = credit_number[19:0:-1]
index_num = credit_number[::1] #same thing as line 16

print(index_num)
