const log = t => console.log(t)

const funcs = []

for (var i = 0; i < 10; i++) {
    funcs.push(function() {
        log(i)
    })
}

funcs[2]()
funcs[8]()